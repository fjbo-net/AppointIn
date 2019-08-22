using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointIn.Core
{
	public static class AppActions
	{
		#region Properties
		// Using lambda expressino to simplify function return value reference
		public static Action<Exception> ErrorHandler = (exception)
			=> Console.WriteLine($"Error '{exception.GetType().ToString()}' encountered: \n{exception.Message} \n {exception.StackTrace}");
		#endregion


		#region Methods
		internal static string GetLogPath()
		{
			if (!Directory.Exists(AppConfig.LogDirectory)) Directory.CreateDirectory(AppConfig.LogDirectory);
			return AppConfig.LogDirectory;
		}

		// Using lambda expressino to simplify function return value reference
		public static void HandleError(Exception exception) => ErrorHandler?.Invoke(exception);

		public static Result<TypeOfResult> HandleErrorWithResult<TypeOfResult>(Exception exception, TypeOfResult value, List<string> messages)
		{
			HandleError(exception);
			return new Result<TypeOfResult>(value, messages);
		}
		#endregion
	}
}
