
using CreativeMinds.CQS.Queries;
using System.Threading;
using System.Threading.Tasks;

namespace MyApp.Namespace {

	public class MyQueryHandler : IAsyncQueryHandler<MyQuery, MyQueryResult> {

		public Task<MyQueryResult> HandleAsync(MyQuery query, CancellationToken cancellationToken) {
			throw new System.NotImplementedException();
		}
	}
}
