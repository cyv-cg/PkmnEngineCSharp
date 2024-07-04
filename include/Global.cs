using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

using System.Globalization;
using System.Text;
using System;

using static PkmnEngine.Global;
using System.Threading.Tasks;

namespace PkmnEngine {
	public static class Global {
		public const u16 WAIT_DELAY = 100;

		public const double EPSILON = 0.0001d;

		public static Func<string, Task> MessageBox;
		public static Action<BattleMon, Ability> AbilityPopup;

		public const float TEXT_DISPLAY_SECONDS = 1f;
		public const float TEXT_SPEED = 0.025f;

		public static u16 HIHALF32(u32 n) { return (u16)((n & 0xFFFF0000) >> 16); }
		public static u16 LOHALF32(u32 n) { return (u16)(n & 0xFFFF); }

		public static u8 HIHALF16(u16 n) { return (u8)((n & 0xFF00) >> 8); }
		public static u8 LOHALF16(u16 n) { return (u8)(n & 0xFF); }

		public static u8 HIHALF8(u16 n) { return (u8)((n & 0xF0) >> 4); }
		public static u8 LOHALF8(u16 n) { return (u8)(n & 0xF); }

		/// <summary>
		/// Converts a string to a hexadecimal representation.
		/// </summary>
		/// <param name="utfString">String to convert.</param>
		/// <returns>Hex representation of the given string.</returns>
		public static string StringToHex(string utfString) {
			string hexString = "";

			for (int i = 0; i < utfString.Length; i++) {
				hexString += ((int)utfString[i]).ToString($"X{WCHAR_LEN}");
			}

			return hexString;
		}
		/// <summary>
		/// Converts a hexadecimal string to its UTF-8 representation.
		/// </summary>
		/// <param name="hexString">Hex string to convert.</param>
		/// <returns>Parsed string.</returns>
		public static string HexToString(string hexString) {
			string utfString = "";

			for (int i = 0; i < hexString.Length; i += WCHAR_LEN) {
				utfString += (char)short.Parse(hexString.Substring(i, WCHAR_LEN), NumberStyles.AllowHexSpecifier);
			}

			return utfString;
		}

		public const u8 WCHAR_LEN = 4;

		public static u32 GetShinyValue(u32 otId, u32 personality) { 
			return (u32)(	HIHALF32(otId) 			^ LOHALF32(otId) 
						^	HIHALF32(personality)	^ LOHALF32(personality)
			); 
		}
		// Shiny odds
		public const u16 SHINY_ODDS = 8; // Actual probability is SHINY_ODDS/65536

		public const u8 PARTY_SIZE = 6;

		public const sbyte MIN_STAT_STAGE = -6;
		public const sbyte MAX_STAT_STAGE = 6;

		public const u8 MIN_IV = 0;
		public const u8 MAX_IV = 31;
		public const u8 MAX_IV_MASK = 0b00011111;

		public const u8 MIN_EV = 0;
		public const u8 MAX_EV = 255;
		public const u16 MAX_EV_TOTAL = 2 * 252 + 4;

		public const u8 MON_GENDERLESS = 0;
		public const u8 MON_MALE = 1;
		public const u8 MON_FEMALE = 2;

		public const u8 MAX_NAME_LENGTH = 16;

		public const u8 NUM_LANGS = (u8)Language.NR_ITEMS;

		public static float Random01(Random rand = null) {
			rand ??= new Random();
			return (float)rand.NextDouble();
		}
		public static u16 Random16(Random rand = null) {
			rand ??= new Random();
			return (u16)(rand.Next() & 0xFFFF);
		}
		public static u32 Random32(Random rand = null) {
			return ((u32)Random16(rand) << 16) | Random16(rand);
		}
		public static u64 Random64(Random rand = null) {
			return ((u64)Random32(rand) << 32) | Random32(rand);
		}

		public static SaveBlock gSaveBlock;
	}

	public class SaveBlock
	{
		//public string playerName;
		public u32 trainerID;
		//public Pokemon[] party;
		public Language language;

		public TrainerProfile profile;

		/// <summary>
		/// Determines if furigana will be displayed alongside kanji when playing in Japanese.
		/// </summary>
		public bool JPN_USE_FURIGANA = true;
	};

	public class Buffer {
		public Buffer() {
			buffer = new StringBuilder(0);
			SetCursor(0);
		}
		public Buffer(u16 size) {
			buffer = new StringBuilder(new string('0', size));
			SetCursor(0);
		}
		public Buffer(string data, bool startCursorAtEnd = false) {
			buffer = new StringBuilder(data);
			if (startCursorAtEnd) {
				SetCursor((u16)data.Length);
			}
			else {
				SetCursor(0);
			}
		}

		private readonly StringBuilder buffer;
		public u16 Size { get { return (u16)buffer.Length; } }
		public u16 Cursor { get; private set; }

		/// <summary>
		/// Sets the buffer.Cursor to a given position.
		/// </summary>
		/// <param name="pos">The new position of the cursor.</param>
		public void SetCursor(u16 pos) {
			Cursor = pos;
		}
		public bool IsEmpty() {
			return Size == 0;
		}

		/// <summary>
		/// Writes an unsigned 64-bit int to the buffer.
		/// </summary>
		/// <param name="value"></param>
		public void AddValue(u64 value) {
			u8 size = (u8)MathF.Ceiling(64 / WCHAR_LEN);
			buffer.Insert(Cursor, value.ToString($"X{size}"));
			SetCursor((u16)(Cursor + size));
		}
		/// <summary>
		/// Writes an unsigned 32-bit int to the buffer.
		/// </summary>
		/// <param name="value"></param>
		public void AddValue(u32 value) {
			u8 size = (u8)MathF.Ceiling(32 / WCHAR_LEN);
			buffer.Insert(Cursor, value.ToString($"X{size}"));
			SetCursor((u16)(Cursor + size));
		}
		/// <summary>
		/// Writes an unsigned 16-bit int to the buffer.
		/// </summary>
		/// <param name="value"></param>
		public void AddValue(u16 value) {
			u8 size = (u8)MathF.Ceiling(16 / WCHAR_LEN);
			buffer.Insert(Cursor, value.ToString($"X{WCHAR_LEN}"));
			SetCursor((u16)(Cursor + size));
		}
		/// <summary>
		/// Writes an unsigned 8-bit int to the buffer.
		/// </summary>
		/// <param name="value"></param>
		public void AddValue(u8 value) {
			u8 size = (u8)MathF.Ceiling(8 / WCHAR_LEN);
			buffer.Insert(Cursor, value.ToString($"X{size}"));
			SetCursor((u16)(Cursor + size));
		}
		/// <summary>
		/// Writes a signed 8-bit int to the buffer.
		/// </summary>
		/// <param name="value"></param>
		public void AddValue(sbyte value) {
			u8 size = (u8)MathF.Ceiling(8 / WCHAR_LEN);
			u8 newVal = (u8)BitConverter.ToUInt16(BitConverter.GetBytes(value), 0);
			buffer.Insert(Cursor, newVal.ToString($"X{size}"));
			SetCursor((u16)(Cursor + size));
		}
		/// <summary>
		/// Writes a float to the buffer.
		/// </summary>
		/// <param name="value"></param>
		public void AddValue(float value) {
			AddValue(BitConverter.ToUInt32(BitConverter.GetBytes(value), 0));
		}
		/// <summary>
		/// Writes a bool to the buffer.
		/// </summary>
		/// <param name="value"></param>
		public void AddValue(bool value) {
			u8 size = 1;
			buffer.Insert(Cursor, (value ? 1 : 0).ToString($"X{size}"));
			SetCursor((u16)(Cursor + size));
		}
		/// <summary>
		/// Writes a string to the buffer.
		/// </summary>
		/// <param name="value"></param>
		/// <param name="fill">If fill > 0, pad the string to the left with null characters to the desired length.</param>
		public void AddValue(string value, u16 fill = 0) {
			string filledValue = value.PadLeft(fill, (char)0);
			buffer.Insert(Cursor, StringToHex(filledValue));
			SetCursor((u16)(Cursor + filledValue.Length * WCHAR_LEN));
		}
		/// <summary>
		/// Writes a string to the buffer.
		/// </summary>
		/// <param name="value"></param>
		/// <param name="raw">If true, does not convert to hex first.</param>
		public void AddValue(string value, bool raw) {
			if (raw) {
				buffer.Insert(Cursor, value);
				SetCursor((u16)(Cursor + value.Length));
			}
			else {
				AddValue(value, 0);
			}
		}
		/// <summary>
		/// Writes a buffer to the buffer.
		/// </summary>
		/// <param name="value"></param>
		public void AddValue(Buffer value) {
			// Include the size of the buffer in the value so that it can be read back at the same size.
			AddValue(value.Size);
			AddValue(value.buffer.ToString(), true);
		}
		/// <summary>
		/// Writes a serializable object to the buffer.
		/// </summary>
		/// <param name="value"></param>
		/// <typeparam name="T"></typeparam>
		public void AddValue<T>(T value) where T : ISerializable<T> {
			AddValue(value.Write());
		}

		public u64 Read64() {
			u8 size = (u8)MathF.Ceiling(64 / WCHAR_LEN);
			u64 value = ulong.Parse(buffer.ToString().Substring(Cursor, size), NumberStyles.AllowHexSpecifier);
			SetCursor((u16)(Cursor + size));
			return value;
		}
		public u32 Read32() {
			u8 size = (u8)MathF.Ceiling(32 / WCHAR_LEN);
			u32 value = uint.Parse(buffer.ToString().Substring(Cursor, size), NumberStyles.AllowHexSpecifier);
			SetCursor((u16)(Cursor + size));
			return value;
		}
		public u16 Read16() {
			u8 size = (u8)MathF.Ceiling(16 / WCHAR_LEN);
			u16 value = ushort.Parse(buffer.ToString().Substring(Cursor, size), NumberStyles.AllowHexSpecifier);
			SetCursor((u16)(Cursor + size));
			return value;
		}
		public u8 Read8() {
			u8 size = (u8)MathF.Ceiling(8 / WCHAR_LEN);
			u8 value = byte.Parse(buffer.ToString().Substring(Cursor, size), NumberStyles.AllowHexSpecifier);
			SetCursor((u16)(Cursor + size));
			return value;
		}
		public sbyte Reads8() {
			u8 size = (u8)MathF.Ceiling(8 / WCHAR_LEN);
			u8 value = byte.Parse(buffer.ToString().Substring(Cursor, size), NumberStyles.AllowHexSpecifier);
			SetCursor((u16)(Cursor + size));
			return (sbyte)BitConverter.ToInt16(BitConverter.GetBytes(value), 0);
		}
		public float ReadFloat() {
			return BitConverter.ToSingle(BitConverter.GetBytes(Read32()));
		}
		public bool ReadBool() {
			u8 size = 1;
			bool value = byte.Parse(buffer.ToString().Substring(Cursor, size), NumberStyles.AllowHexSpecifier) != 0;
			SetCursor((u16)(Cursor + size));
			return value;
		}
		public string ReadString(u16 length) {
			string value = HexToString(buffer.ToString().Substring(Cursor, length * WCHAR_LEN)).Replace(((char)0).ToString(), "");
			SetCursor((u16)(Cursor + length * WCHAR_LEN));
			return value;
		}
		public string ReadString(u16 length, bool raw) {
			if (raw) {
				string value = buffer.ToString().Substring(Cursor, length).Replace(((char)0).ToString(), "");
				SetCursor((u16)(Cursor + length));
				return value;
			}
			else {
				return ReadString(length);
			}
		}
		public Buffer ReadBuffer() {
			u16 size = Read16();
			Buffer value = new Buffer(ReadString(size, true));
			return value;
		}
	}

	public enum Language {
		ENG,
		JPN,
		GER,
		FRE,
		ITA,
		SPN,
		KOR,
		CHN_SIM,
		CHN_TRA,
		NR_ITEMS
	};

	public enum OtIdType {
		RANDOM_NO_SHINY,
		PRESET,
		PLAYER
	};
}