using System;
using System.Collections.Generic;

namespace SecureSafe.Models
{
	public class BeerModel
	{

            public int Id { get; set; }
            public string Name { get; set; }
            public string Tagline { get; set; }
            public string FirstBrewed { get; set; }
            public string Description { get; set; }
            public string ImageUrl { get; set; }
            public double Abv { get; set; }
            public double? Ibu { get; set; }
            public double TargetFg { get; set; }
            public double TargetOg { get; set; }
            public double? Ebc { get; set; }
            public double? Srm { get; set; }
            public double? Ph { get; set; }
            public double AttenuationLevel { get; set; }
            public Volume Volume { get; set; }
            public Volume BoilVolume { get; set; }
            public BrewingMethod Method { get; set; }
            public Ingredients Ingredients { get; set; }
            public List<string> FoodPairing { get; set; }
            public string BrewersTips { get; set; }
            public string ContributedBy { get; set; }
        }

        public class Volume
        {
            public double Value { get; set; }
            public string Unit { get; set; }
        }

        public class BrewingMethod
        {
            public List<MashTemp> MashTemp { get; set; }
            public Fermentation Fermentation { get; set; }
            public object Twist { get; set; }
        }

        public class MashTemp
        {
            public Temperature Temp { get; set; }
            public int Duration { get; set; }
        }

        public class Fermentation
        {
            public Temperature Temp { get; set; }
        }

        public class Temperature
        {
            public double Value { get; set; }
            public string Unit { get; set; }
        }

        public class Ingredients
        {
            public List<Malt> Malt { get; set; }
            public List<Hop> Hops { get; set; }
            public string Yeast { get; set; }
        }

        public class Malt
        {
            public string Name { get; set; }
            public Volume Amount { get; set; }
        }

        public class Hop
        {
            public string Name { get; set; }
            public Volume Amount { get; set; }
            public string Add { get; set; }
            public string Attribute { get; set; }
        }


    }


