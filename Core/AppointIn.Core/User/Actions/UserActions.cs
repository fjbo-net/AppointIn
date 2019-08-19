using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointIn.Core
{
	public static class UserActions
	{
		private static string LoginLogPath = $"{AppActions.GetLogPath()}{Path.DirectorySeparatorChar}Logins.txt";

		public static Result<Domain.Entities.User> LogUserIn
			(this Domain.Repositories.IUserRepository userRepository, string username, string password)
		{
			var messages = new List<string>();
			Domain.Entities.User outputValue = null;

			try
			{
				Domain.Entities.User user = userRepository.GetByUsername(username);

				if(user != null)
				{
					if(user.Password.Equals(password))
					{
						outputValue = user;

						var logLoginResult = LogLogin(user.Username);

						messages.Add(Resources.UserStrings.LoginSuccessMessage);
					}
					else
					{
						messages.Add(Resources.UserStrings.LoginInvalidPasswordMessage);
					}
				} else
				{
					messages.Add(string.Format(Resources.UserStrings.LoginInvalidUsernameMessage, username));
				}

				return new Result<Domain.Entities.User>
					(value: outputValue,
					messages: messages);
			}
			catch(Exception ex)
			{
				return AppActions.HandleErrorWithResult<Domain.Entities.User>(ex, null, messages);
			}
		}

		private static Result<bool> LogLogin(string username)
		{
			var messages = new List<string>();
			try
			{
				using(var outputFile = new StreamWriter(LoginLogPath, true, Encoding.UTF8))
				{
					outputFile.WriteLine($"{DateTime.Now.ToString()},{username}");
				}

				messages.Add("Login was successfully logged.");

				return new Result<bool>(true, messages);
			} catch (Exception ex)
			{
				return AppActions.HandleErrorWithResult(ex, false, messages);
			}
		}
	}
}
