using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Reflection;

namespace Matplan.API.Extensions;


public class DisplayEnumSchemaFilter : ISchemaFilter
{
    public void Apply(OpenApiSchema schema, SchemaFilterContext context)
    {
        if (!context.Type.IsEnum) return;

        //schema.Enum.Clear();
        //schema.Description ??= "";
        var description = "";


        foreach (var enumValue in Enum.GetValues(context.Type))
        {
            var name = enumValue.ToString();
            var member = context.Type.GetMember(name!).FirstOrDefault();
            var display = member?.GetCustomAttribute<DisplayAttribute>();
            var displayName = display?.Name ?? name;

            // Swagger visar detta i dropdownen
            //schema.Enum.Add(new Microsoft.OpenApi.Any.OpenApiString(displayName));
            
            // Lägg till tooltip-information
            description += $"{displayName} = {name}\n";
        }

        // Men värdet som skickas är enum-namnet
        //schema.Type = "string";
        schema.Description = description;


    }
}

