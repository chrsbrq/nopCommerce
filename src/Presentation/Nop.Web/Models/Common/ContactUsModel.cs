using System.ComponentModel.DataAnnotations;
using Nop.Web.Framework.Models;
using Nop.Web.Framework.Mvc.ModelBinding;

namespace Nop.Web.Models.Common;

public partial record ContactUsModel : BaseNopModel
{
    [DataType(DataType.EmailAddress)]
    [NopResourceDisplayName("ContactUs.Email")]
    public string Email { get; set; }

    [Required]
    [NopResourceDisplayName("ContactUs.Subject")]
    public string Subject { get; set; }
    public bool SubjectEnabled { get; set; }

    [NopResourceDisplayName("ContactUs.Enquiry")]
    public string Enquiry { get; set; }

    [NopResourceDisplayName("ContactUs.FullName")]
    public string FullName { get; set; }

    public bool SuccessfullySent { get; set; }
    public string Result { get; set; }

    public bool DisplayCaptcha { get; set; }
    public string ProductName { get; set; }
    public string ProductUrl { get; set; }

    [NopResourceDisplayName("ContactUs.Phone")]
    public string Phone { get; set; }

    [NopResourceDisplayName("ContactUs.EventDate")]
    public string EventDate { get; set; }

    [Required]
    [NopResourceDisplayName("ContactUs.HearAboutUs")]
    public string HearAboutUs { get; set; }

    [NopResourceDisplayName("ContactUs.Venue")]
    public string Venue { get; set; }
}