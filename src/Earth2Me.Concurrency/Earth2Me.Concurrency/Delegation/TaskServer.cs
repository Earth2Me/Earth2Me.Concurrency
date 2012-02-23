using System;
using System.Threading;

namespace Earth2Me.Concurrency.Delegation
{
	public class TaskServer
	{
		private readonly TaskWorker[] Workers;

		public int LowestPriority { get; private set; }

		public TaskServer()
			: this(0)
		{
			// Intentionally blank.
		}

		public TaskServer(int lowestPriority)
			: this(lowestPriority, ThreadPriority.Normal)
		{
			// Intentionally blank.
		}

		public TaskServer(int lowestPriority, ThreadPriority workerPriority)
			: this(lowestPriority, workerPriority, 0)
		{
			// Intentionally blank.
		}

		public TaskServer(int lowestPriority, ThreadPriority workerPriority, int workers)
		{
			if (workers < 1)
			{
				workers = Environment.ProcessorCount;
			}

			Workers = new TaskWorker[workers];
			for (int i = 0; i < workers; i++)
			{
			}
		}
	}
}