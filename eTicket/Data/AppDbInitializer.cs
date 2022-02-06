using eTicket.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eTicket.Data.Enums;
using eTicket.Data;

namespace eTicket.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder builder)
        {
            using (var scope = builder.ApplicationServices.CreateScope())
            {
                var context = scope.ServiceProvider.GetService<AppDbContext>();
                //Cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Cinema 1",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                            Description = "This is the Cinema 1 Description"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 2",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                            Description = "This is the Cinema 2 Description"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 3",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                            Description = "This is the Cinema 3 Description"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 4",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-4.jpeg",
                            Description = "This is the Cinema 4 Description"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 5",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-5.jpeg",
                            Description = "This is the Cinema 5 Description"
                        }
                    });
                    context.SaveChanges();
                }

                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "Actor 1",
                            ProfilePictureUrl = "http://dotnethow.net/images/actors/actor-1.jpeg",
                            Bio = "This is the Actor 1 Description"
                        },
                        new Actor()
                        {
                            FullName = "Actor 2",
                            ProfilePictureUrl = "http://dotnethow.net/images/actors/actor-2.jpeg",
                            Bio = "This is the Actor 2 Description"
                        },
                        new Actor()
                        {
                            FullName = "Actor 3",
                            ProfilePictureUrl = "http://dotnethow.net/images/actors/actor-3.jpeg",
                            Bio = "This is the Actor 3 Description"
                        },
                        new Actor()
                        {
                            FullName = "Actor 4",
                            ProfilePictureUrl = "http://dotnethow.net/images/actors/actor-4.jpeg",
                            Bio = "This is the Actor 4 Description"
                        },
                        new Actor()
                        {
                            FullName = "Actor 5",
                            ProfilePictureUrl = "http://dotnethow.net/images/actors/actor-5.jpeg",
                            Bio = "This is the Actor 5 Description"
                        }
                    });
                    context.SaveChanges();
                }


                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Producer 1",
                            ProfilePictureUrl = "http://dotnethow.net/images/producers/producer-1.jpeg",
                            Bio = "This is the Producer 1 Description"
                        },
                        new Producer()
                        {
                            FullName = "Producer 2",
                            ProfilePictureUrl = "http://dotnethow.net/images/producers/producer-2.jpeg",
                            Bio = "This is the Producer 2 Description"
                        },
                        new Producer()
                        {
                            FullName = "Producer 3",
                            ProfilePictureUrl = "http://dotnethow.net/images/producers/producer-3.jpeg",
                            Bio = "This is the Producer 3 Description"
                        },
                        new Producer()
                        {
                            FullName = "Producer 4",
                            ProfilePictureUrl = "http://dotnethow.net/images/producers/producer-4.jpeg",
                            Bio = "This is the Producer 4 Description"
                        },
                        new Producer()
                        {
                            FullName = "Producer 5",
                            ProfilePictureUrl = "http://dotnethow.net/images/producers/producer-5.jpeg",
                            Bio = "This is the Producer 5 Description"
                        }
                    });
                    context.SaveChanges();
                }

                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie
                        {
                            Name="Movie 1",
                            Description="Movie 1 Description",
                            Price=39.50,
                            ImageUrl="http://dotnethow.net/images/movies/movie-1.jpeg",
                            StartDate=DateTime.Now.AddDays(-10),
                            EndDate=DateTime.Now.AddDays(8),
                            CinemaId=1,
                            ProducerId=3,
                            MovieCategory=MovieCategory.Action
                        },
                        new Movie
                        {
                            Name="Movie 2",
                            Description="Movie 2 Description",
                            Price=49.50,
                            ImageUrl="http://dotnethow.net/images/movies/movie-2.jpeg",
                            StartDate=DateTime.Now.AddDays(-10),
                            EndDate=DateTime.Now.AddDays(8),
                            CinemaId=1,
                            ProducerId=3,
                            MovieCategory=MovieCategory.Comedy
                        },
                        new Movie
                        {
                            Name="Movie 3",
                            Description="Movie 3 Description",
                            Price=29.50,
                            ImageUrl="http://dotnethow.net/images/movies/movie-3.jpeg",
                            StartDate=DateTime.Now.AddDays(-10),
                            EndDate=DateTime.Now.AddDays(8),
                            CinemaId=1,
                            ProducerId=3,
                            MovieCategory=MovieCategory.Horror
                        },
                        new Movie
                        {
                            Name="Movie 4",
                            Description="Movie 4 Description",
                            Price=19.50,
                            ImageUrl="http://dotnethow.net/images/movies/movie-4.jpeg",
                            StartDate=DateTime.Now.AddDays(-10),
                            EndDate=DateTime.Now.AddDays(8),
                            CinemaId=1,
                            ProducerId=3,
                            MovieCategory=MovieCategory.Drama
                        },
                        new Movie
                        {
                            Name="Movie 5",
                            Description="Movie 5 Description",
                            Price=29.50,
                            ImageUrl="http://dotnethow.net/images/movies/movie-5.jpeg",
                            StartDate=DateTime.Now.AddDays(-10),
                            EndDate=DateTime.Now.AddDays(8),
                            CinemaId=1,
                            ProducerId=3,
                            MovieCategory=MovieCategory.Documentary
                        }
                    });
                    context.SaveChanges();
                }

                //Actors and Movies

                if (!context.Actor_Movies.Any())
                {
                    context.Actor_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId=1, MovieId=1
                        },
                        new Actor_Movie()
                        {
                            ActorId=2, MovieId=1
                        },
                        new Actor_Movie()
                        {
                           ActorId=3, MovieId=1
                        },
                        new Actor_Movie()
                        {
                           ActorId=4, MovieId=2
                        },
                        new Actor_Movie()
                        {
                            ActorId=5, MovieId=2
                        },
                        new Actor_Movie()
                        {
                           ActorId=2, MovieId=3
                        },
                        new Actor_Movie()
                        {
                            ActorId=3, MovieId=3
                        },
                        new Actor_Movie()
                        {
                            ActorId=4, MovieId=4
                        },
                        new Actor_Movie()
                        {
                           ActorId=5, MovieId=4
                        },
                        new Actor_Movie()
                        {
                            ActorId=1, MovieId=5
                        },
                        new Actor_Movie()
                        {
                            ActorId=4, MovieId=5
                        },
                        new Actor_Movie()
                        {
                           ActorId=5, MovieId=5
                        }
                    });
                    context.SaveChanges();
                }


            }


        }
    }
}