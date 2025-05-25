using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.ConstrainedExecution;
using Microsoft.Build.Framework;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace API.DTOs;

public class RegisterDto
{
  [Required]

  public string UserName { get; set; } = string.Empty;

  [Required]
  [StringLength(8, MinimumLength = 4)]
  public string Password { get; set; } = string.Empty;
}
