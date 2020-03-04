using CreativeMinds.CQS.Permissions;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;

namespace MyApp.Namespace {

	public class MyQueryPermissionCheck : IAsyncPermissionCheck<MyQuery> {

		public Task<IPermissionCheckResult> CheckAsync(MyQuery message, IIdentity user, CancellationToken cancellationToken) {
			throw new System.NotImplementedException();
		}
	}
}
