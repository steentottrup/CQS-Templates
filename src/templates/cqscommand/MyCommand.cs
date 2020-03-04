using CreativeMinds.CQS.Commands;
using CreativeMinds.CQS.Decorators;

namespace MyApp.Namespace {

#if (!no-validator)
	[Validate]
#endif
#if (!no-permissioncheck)
	[CheckPermissions]
#endif
	public class MyCommand : ICommand {

	}
}