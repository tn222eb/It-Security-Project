using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;
using System.Net.Mail;
using System.Web.Security;

namespace Forum_It_Security_Project.Model
{
    public class Member : Base
    {
        private string _userName;
        private string _passWord;
        private string _confirmPassword;

        public enum Roles
        {
            Member,
            Moderator,
            Admin
        }
        private Roles _Role = Roles.Member;
        public Roles Role
        {
            get { return this._Role; }
            set { _Role = value; }
        }

        public Member(string userName, string passWord, string confirmPassword)
        {
            //construct

            this._userName = userName;
            this._passWord = passWord;
            this._confirmPassword = confirmPassword;
        }

        public string UserName
        {
            get
            {
                return _userName;
            }

            set
            {

                errorValidation.Remove("UserName");
                if (String.IsNullOrWhiteSpace(value))
                {
                    errorValidation.Add("UserName", "user name is required!");
                }
                else if (value != Regex.Replace(value, "<.*?>", string.Empty))
                {
                    errorValidation.Add("UserName", "special characters are not allowed");
                }
                else if (value.Length > 30)
                {
                    errorValidation.Add("UserName", "you can not write a username with more than 30 characters");
                }
             
                _userName = value != null ? value.Trim() : null;
            }
        }


        public  string  PassWord
        {
            get
            {
                return _passWord;
            }
            set
            {
                errorValidation.Remove("Password");
                if (String.IsNullOrWhiteSpace(value))
                {
                    errorValidation.Add("Password","the password is required");
                }
                else if (value.Length > 30)
                {
                    errorValidation.Add("Password", "you can not write a password with more than 30 characters");
                }
                _passWord = value != null ? value.Trim() : null;
            }
        }


        public string ConfirmPassword
        {
            get
            {
                return _confirmPassword;
            }
            set
            {
                errorValidation.Remove("ConfirmPassword");
                if (String.IsNullOrWhiteSpace(value))
                {
                    errorValidation.Add("ConfirmPassword", "this filed is required");
                }
                else if (value != _passWord)
                {
                    errorValidation.Add("ConfirmPassword", "this password dont match your password");
                }
                _confirmPassword = value != null ? value.Trim() : null;
            }
        }

        public int MemberID
        {
            get;
            set;
        }
    }
}