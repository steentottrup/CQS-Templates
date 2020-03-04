using CreativeMinds.CQS.Validators;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MyApp.Namespace {

	public class MyQueryValidator : IAsyncValidator<MyQuery> {

		public Task<ValidationResult> ValidateAsync(MyQuery msg, CancellationToken cancellationToken) {
			throw new NotImplementedException();
		}
	}
}
