﻿using NetTopologySuite.Geometries;
using System.ComponentModel.DataAnnotations;
using WebApplication1.TestData;

namespace WebApplication1.Models;

public class Country
{
    public Country()
    {
    }

    public Country(CountryJsonData jsonData)
    {
        IsoCode = jsonData.IsoCode;
        Name = jsonData.Name.Official;
        Location = new Point(jsonData.LatitudeLongitude.ElementAt(1), jsonData.LatitudeLongitude.ElementAt(0));
    }

    [Key]
    public string Id { get; set; } = Guid.NewGuid().ToString();

    public string IsoCode { get; set; } = string.Empty;

    public string Name { get; set; } = string.Empty;

    public Point Location { get; set; } = new Point(0, 0);

    public double Latitude { get => Location.X; }

    public double Longitude { get => Location.Y; }
}
