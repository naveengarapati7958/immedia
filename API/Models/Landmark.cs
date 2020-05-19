using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Landmark
    {
        public Response response { get; set; }
    }
    public class Response
    {
        public Groups[] groups { get; set; }
    }

    public class Groups
    {
        public Items[] items { get; set; }
    }
    public class Items
    {
        public Venue venue { get; set; }

    }

    //"venue": {
    //                        "id": "4b93823cf964a5206b4634e3",
    //                        "name": "Durban Botanic Gardens",
    //                        "location": {
    //                            "address": "70 St Thomas Road",
    //                            "lat": -29.84687587107469,
    //                            "lng": 31.007350219458488,
    //                            "labeledLatLngs": [
    //                                {
    //                                    "label": "display",
    //                                    "lat": -29.84687587107469,
    //                                    "lng": 31.007350219458488
    //                                }
    //                            ],
    //                            "postalCode": "4000",
    //                            "cc": "ZA",
    //                            "city": "ITheku",
    //                            "state": "KwaZulu-Natal",
    //                            "country": "iNingizimu Afrika",
    //                            "formattedAddress": [
    //                                "70 St Thomas Road",
    //                                "ITheku",
    //                                "4000",
    //                                "iNingizimu Afrika"
    //                            ]
    //                        },
    //                        "categories": [
    //                            {
    //                                "id": "4bf58dd8d48988d15a941735",
    //                                "name": "Garden",
    //                                "pluralName": "Gardens",
    //                                "shortName": "Garden",
    //                                "icon": {
    //                                    "prefix": "https://ss3.4sqi.net/img/categories_v2/parks_outdoors/garden_",
    //                                    "suffix": ".png"
    //                                },
    //                                "primary": true
    //                            }
    //                        ],
    //                        "photos": {
    //                            "count": 0,
    //                            "groups": []
    //                        }
    //                    }

    public class Venue
    {
        public string id { get; set; }
        public string name { get; set; }
        public Location location { get; set; }
        //public Categories[] categories { get; set; }                            
    }

    public class Location
    {
        public string address { get; set; }
        public string lat { get; set; }
        public string lng { get; set; }
        //                                "labeledLatLngs": [
        //                                    {
        //                                        "label": "display",
        //                                        "lat": -29.84687587107469,
        //                                        "lng": 31.007350219458488
        //                                    }
        //                                ],
        //                                "postalCode": "4000",
        //                                "cc": "ZA",
        //                                "city": "ITheku",
        //                                "state": "KwaZulu-Natal",
        //                                "country": "iNingizimu Afrika",
        //                                "formattedAddress": [
        //                                    "70 St Thomas Road",
        //                                    "ITheku",
        //                                    "4000",
        //                                    "iNingizimu Afrika"
        //                                ]
        //},
    }
    //public class Categories
    //{
    //}

}