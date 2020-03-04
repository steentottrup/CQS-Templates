using CreativeMinds.CQS.Validators;
using System.Threading;
using System.Threading.Tasks;

namespace MyApp.Namespace {

	public class CommandValidator : IAsyncValidator<MyCommand> {

		public Task<ValidationResult> ValidateAsync(MyCommand msg, CancellationToken cancellationToken) {
			throw new System.NotImplementedException();
		}
	}
}