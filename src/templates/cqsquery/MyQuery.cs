
using CreativeMinds.CQS.Decorators;
using CreativeMinds.CQS.Queries;

namespace MyApp.Namespace {

#if (!no-validator)
	[Validate]
#endif
#if (!no-permissioncheck)
	[CheckPermissions]
#endif
	public class MyQuery : IQuery<MyQueryResult> {

	}
}