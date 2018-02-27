using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using WickedWebApi.BL.AccountManager;
using WickedWebApi.BL.Logger;

namespace WickedWebApi.Controllers
{
   public class AccountController : Controller
   {
       private static Logger _logger;
       private static IUserManager _userManager;

       public AccountController()
       {
            _logger=new Logger();
           _userManager = new UserManager();
       }

      [HttpGet]
      public bool CheckEmail(string email)
      {
          try
          {
              _logger.Info($"Started executing -> AccountController CheckEmail(email={email})");
              Console.WriteLine(_userManager.CheckEmail(email));
              return _userManager.CheckEmail(email);
          }
          catch (Exception ex)
          {
              _logger.Error(ex.Message);
              return false;
          }
          finally
          {
                _logger.Info($"Finished executing -> AccountController CheckEmail(email={email})");
          }
      }

       [HttpGet]
       public int LogIn(string email,string password)
       {
           try
           {
               _logger.Info($"Started executing -> AccountController LogIn(email={email},password={password})");
               //Console.WriteLine(_userManager.CheckEmail(email));
               return _userManager.LogIn(email,password);
           }
           catch (Exception ex)
           {
               _logger.Error(ex.Message);
               return 0;
           }
           finally
           {
               _logger.Info($"Finished executing -> AccountController LogIn(email={email},password={password})");
           }
       }

       [HttpGet]
       public int Register(string email, string password,string foreignLanguage)
       {
           try
           {
               _logger.Info($"Started executing -> AccountController Register(email={email},password={password},foreignLanguage={foreignLanguage})");
               //Console.WriteLine(_userManager.CheckEmail(email));
               return _userManager.Register(email, password,foreignLanguage);
           }
           catch (Exception ex)
           {
               _logger.Error(ex.Message);
               return 0;
           }
           finally
           {
               _logger.Info($"Finished executing -> AccountController Register(email={email},password={password},foreignLanguage={foreignLanguage})");
           }
       }


    }
}
