using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WindowsForms_stock_quote_alert
{
    public class AbortableBackgroundWorker : BackgroundWorker
    {
        //source: https://stackoverflow.com/questions/800767/how-to-kill-background-worker-completely
        private Thread workerThread;

        protected override void OnDoWork(DoWorkEventArgs e)
        {
            workerThread = Thread.CurrentThread;
            try
            {
                bool bgWorkingRunning = false;
                while (!bgWorkingRunning)
                {
                    if (this.CancellationPending) break;
                    bgWorkingRunning = true;
                    Thread.Sleep(1000 * 60 * 1);
                    this.ReportProgress(1);
                    bgWorkingRunning = false;
                    
                }
                base.OnDoWork(e);
            }
            catch (ThreadAbortException)
            {
                e.Cancel = true; //We must set Cancel property to true!
                Thread.ResetAbort(); //Prevents ThreadAbortException propagation
            }
        }


        public void Abort()
        {
            if (workerThread != null)
            {
                workerThread.Abort();
                workerThread = null;
            }
        }
    }
}
