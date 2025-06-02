using System;

namespace API.Extensions;

public static class DateTimeExtensions
{


    public static int CalculateAge(this DateOnly dob)
    {
        var today = DateOnly.FromDateTime(DateTime.Now);
        var age = today.Year - dob.Year;
        if (dob > today.AddYears(-age)) age--;
        return age;
    }

    // public static int CalculateAge(this DateTime dob)
    // {
    //     if (dob > DateTime.Today)
    //         throw new ArgumentException("Date of birth cannot be in the future.", nameof(dob));

    //     var today = DateTime.Today;
    //     var age = today.Year - dob.Year;

    //     // Check if birthday has not occurred yet this year
    //     if (today.Month < dob.Month || (today.Month == dob.Month && today.Day < dob.Day))
    //     {
    //         age--;
    //     }

    //     return age;
    // }


}


