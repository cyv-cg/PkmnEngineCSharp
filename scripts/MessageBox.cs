using Godot;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PkmnEngine.GodotV {
	public partial class MessageBox : NinePatchRect {
		private static RichTextLabel label;
		private static Timer displayTimer;
		private static Timer crawlTimer;

		private static Queue<string> messageQueue;

		private static string currentMessage;
		private static byte currentCrawlLen;
		private static bool finishedDisplaying;
		
		public override void _Ready() {
			label = GetNode<RichTextLabel>("MessageBox");
			displayTimer = GetNode<Timer>("MessageTimer");
			crawlTimer = GetNode<Timer>("CrawlTimer");
			
			messageQueue = new Queue<string>();

			displayTimer.Timeout += UpdateMessage;
			displayTimer.Timeout += () => { finishedDisplaying = true; };
			displayTimer.WaitTime = Global.TEXT_DISPLAY_SECONDS;

			crawlTimer.Timeout += Crawl;
			crawlTimer.WaitTime = Global.TEXT_SPEED;
		}

		// Runs when the current message is done showing.
		private static void UpdateMessage() {
			// Clear the current message.
			displayTimer.Stop();
			finishedDisplaying = false;

			// If there is another message in the queue, start showing it.
			if (messageQueue.Count > 0) {
				currentMessage = messageQueue.Dequeue();
				currentCrawlLen = 0;
				crawlTimer.Start();
			}
		}

		// Adds another character to the message being shown.
		private void Crawl() {
			crawlTimer.Stop();

			// If we are not showing the whole string.
			if (currentCrawlLen < currentMessage.Length) {
				// Add in the next character.
				currentCrawlLen++;
				label.Text = currentMessage.Substr(0, currentCrawlLen);
				// Count down the time until showing the next next character.
				crawlTimer.Start();
			}
			else {
				// Count down to show the next message.
				displayTimer.Start();
			}
		}

		/// <summary>
		/// Add a new message to the queue.
		/// </summary>
		/// <param name="s"></param>
		public static void Push(string s) {
			messageQueue.Enqueue(s);
			if (currentMessage == null) {
				UpdateMessage();
			}
		}

		/// <summary>
		/// Add a message to the queue and wait for it to finish displaying.
		/// </summary>
		/// <param name="s"></param>
		public static async Task Display(string s) {
			messageQueue.Enqueue(s);
			UpdateMessage();

			while (!finishedDisplaying) {
				await Task.Delay(10);
			}
		}
	}
}