// namespace CosmicCore.Server.Utilities.Command.Commands;
//
// [Command(Names = ["tplt", "template"],
//     Description = "Does not do anything.",
//     Usage = "yes|no",
//     RequiredPermissions = ["yes", "no"])]
// public class TemplateCommand : ICommand
// {
//     public override Dictionary<int, string> ReturnCodeMap { get; } = new()
//     {
//         { 100, "Did not do anything" }
//     };
//
//     public override int OnExecute(string args, Account.Account executor)
//     {
//         var arguments = CommandUtilities.SplitArgs(args).ToArray();
//         return 100;
//     }
// }
