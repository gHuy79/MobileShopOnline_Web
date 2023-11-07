using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MobileShopOnline.Controllers.Validation
{
        public class LoginValidation
        {
            [Required(ErrorMessage = "Vui lòng nhập địa chỉ email")]
            [EmailAddress(ErrorMessage = "Địa chỉ email không hợp lệ")]
            [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Địa chỉ email không hợp lệ")]
            public string UserEmail { get; set; }
            [Required(ErrorMessage = "Vui lòng nhập mật khẩu")]
            [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$",
             ErrorMessage = "Mật khẩu phải có ít nhất 8 ký tự, bao gồm ít nhất một chữ cái viết hoa, một chữ cái viết thường, một số và một ký tự đặc biệt")]
            public string UserPassword { get; set; }

        }
}