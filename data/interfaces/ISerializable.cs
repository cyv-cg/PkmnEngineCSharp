namespace PkmnEngine {
	public interface ISerializable<TSelf> {
		public Buffer Write() => throw new System.NotImplementedException();
		public static TSelf Load(Buffer data) => throw new System.NotImplementedException();
	}
}