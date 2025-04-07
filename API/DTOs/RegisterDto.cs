using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.ConstrainedExecution;
using Microsoft.Build.Framework;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace API.DTOs;

public class RegisterDto
{
  [Required]
  public required string UserName{get;set;}  

  [Required]
   public required string Password{get;set;} 
}
