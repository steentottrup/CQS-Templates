using CreativeMinds.CQS.Permissions;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;

namespace MyApp.Namespace {

	public class CommandPermissionCheck : IAsyncPermissionCheck<MyCommand> {

		public Task<IPermissionCheckResult> CheckAsync(MyCommand message, IIdentity user, CancellationToken cancellationToken) {
			throw new System.NotImplementedException();
		}
	}
}