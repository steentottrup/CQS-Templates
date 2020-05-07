using CreativeMinds.CQS.Validators;
using System.Threading;
using System.Threading.Tasks;

namespace MyApp.Namespace {

	public class MyCommandValidator : IAsyncValidator<MyCommand> {

		public Task<ValidationResult> ValidateAsync(MyCommand msg, CancellationToken cancellationToken) {
			throw new System.NotImplementedException();
		}
	}
}