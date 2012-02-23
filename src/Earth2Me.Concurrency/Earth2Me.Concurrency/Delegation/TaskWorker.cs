using System.Threading;

namespace Earth2Me.Concurrency.Delegation
{
	/// <summary>
	/// Executes tasks in a unique thread.
	/// </summary>
	public class TaskWorker
	{
		private readonly Thread Thread;

		public TaskWorker(ThreadPriority priority)
		{
		}

		private void Run()
		{
		}
	}
}