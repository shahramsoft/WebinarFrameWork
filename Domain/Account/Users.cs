using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Security;

namespace Domain.Account
{
    [Table("UserProfile")]
    public class Users
    {
     public virtual Guid Id { get;  set; }

        //[Display(Name = "نام کاربری")]
        public virtual string Username { get; set; }//نام کاربری
        public virtual string ApplicationName { get; set; }//نام اپلیکیشن
        public virtual string Email { get; set; }//آدرس ایمیل

        public virtual string Comments { get; set; }//توضیحات
        public virtual string Password { get; set; }//رمز عبور

        public virtual string PasswordQuestion { get; set; }//سوال رمز عبور
        public virtual string PasswordAnswer { get; set; }//جواب 

        public virtual bool  IsApproved { get; set; }//تایید شده
        public virtual DateTime LastActivityDate { get; set; }//آخرین تاریخ فعالیت

        public virtual DateTime LastLoginDate { get; set; }//اخرین تاریخ ورود به سیستم
        public virtual DateTime LastPasswordChangedDate { get; set; }//آخرین تاریخ تغییر رمز عبور
        public virtual DateTime CreationDate { get; set; }//تاریخ ایجاد

        public virtual bool IsOnLine { get; set; }//آنلاین
        public virtual bool IsLockedOut { get; set; }//قفل شده
        public virtual DateTime LastLockedOutDate { get; set; }

        //FailedPasswordAttemptCount
        public virtual int FailedPasswordAc { get; set; }//تعداد دفعات ورود رمز اشتباه
        //FailedPasswordAnswerAttemptCount
        public virtual int FailedPasswordAac { get; set; }

        //FailedPasswordAttemptWindowStart
        public virtual DateTime FailedPasswordAws { get; set; }
        //FailedPasswordAnswerAttemptWindowStart
        public virtual DateTime FailedPasswordAaws { get; set; }



       public virtual Guid PersonId { get; set; }



       public Users()
        {
            Id = Guid.NewGuid();
        }
    }
}
