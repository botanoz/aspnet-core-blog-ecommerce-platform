
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Model;

/// <summary>
/// ApplicationRole class extends IdentityRole to include additional properties.
/// </summary>
public class ApplicationRole : IdentityRole
{
    [StringLength(255)]
    public string? Description { get; set; }
}