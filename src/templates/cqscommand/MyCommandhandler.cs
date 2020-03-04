using CreativeMinds.CQS.Commands;
using System.Threading;
using System.Threading.Tasks;

namespace MyApp.Namespace {

	public class MyCommandHandler : IAsyncCommandHandler<MyCommand> {

		public Task ExecuteAsync(MyCommand command, CancellationToken cancellationToken) {
			throw new System.NotImplementedException();
		}
	}
}