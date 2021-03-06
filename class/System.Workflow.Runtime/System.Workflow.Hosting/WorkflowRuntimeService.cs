// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//
// Authors:
//
//	Copyright (C) 2006 Jordi Mas i Hernandez <jordimash@gmail.com>
//

namespace System.Workflow.Runtime.Hosting
{
	public abstract class WorkflowRuntimeService
	{
		private WorkflowRuntimeServiceState state;
		private WorkflowRuntime runtime;

		protected WorkflowRuntimeService ()
		{
			state = WorkflowRuntimeServiceState.Stopped;
		}

		// Properties
		protected WorkflowRuntime Runtime {
			get { return runtime; }
		}

      		protected WorkflowRuntimeServiceState State {
      			get { return state; }
      		}

		// Methods
		protected virtual void OnStarted ()
		{

		}

		protected virtual void OnStopped ()
		{

		}

		internal void RaiseExceptionNotHandledEvent (Exception exception, Guid instanceId)
		{

		}

		protected void RaiseServicesExceptionNotHandledEvent (Exception exception, Guid instanceId)
		{

		}

		protected internal virtual void Start ()
		{

		}

		protected internal virtual void Stop ()
		{

		}

		// Private methods
		internal void SetRuntime (WorkflowRuntime runtime)
		{
			this.runtime = runtime;
		}
	}
}

