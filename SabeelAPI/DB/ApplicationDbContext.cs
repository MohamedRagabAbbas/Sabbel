using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SabeelAPI.Models;

namespace SabeelAPI.DB
{
  public class ApplicationDbContext: IdentityDbContext
  {
    public DbSet<Details> Details { get; set; }
    public DbSet<TeemMember> TeemMembers { get; set; } 
    public DbSet<Event> Events { get; set; }
    public DbSet<Contacts> Contacts { get; set; }
    public DbSet<User> Users { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {

      builder.Entity<Details>().HasData(
        new Details
        {
          Id = 1,
          About1 = "Sabeel is a dynamic and innovative youth-centered organization dedicated to cultivating the growth of intellectually empowered individuals deeply inspired by the richness of Arab culture, identity, and ideology.",
          About2 = "At the core of our mission is the cultivation of critical thinking and the encouragement of creativity among our members. We believe in instilling a profound sense of curiosity and exploration, empowering young minds to engage thoughtfully with the world around them while embracing the values and traditions of the Arab world.",
          About3 = "Our diverse range of programs and initiatives is meticulously designed to foster a spirit of questioning and inquiry. Whether it's through educational workshops, cultural exchanges, or community projects, we strive to provide avenues for personal growth and societal impact.",
          Mission = "Our mission is to inspire and empower the Arab youth to become leaders and change-makers in their communities, while fostering a deep sense of pride and appreciation for their cultural heritage.",
          vision = "Our vision is to create a global community of Arab youth who are intellectually curious, culturally aware, and socially responsible, and who are committed to making a positive impact in the world.",
          EventsGoal = "Our goal is to create a platform for Arab youth to engage with their culture, history, and identity, and to provide them with the tools and resources to become leaders and change-makers in their communities.",
          YearsOfExperience = 13,
          Attendees = 4312,
          Events = 23,
          funds = 90000,
        });
      builder.Entity<TeemMember>().HasData(
        new TeemMember
        {
          Id = 1,
          Name = "Ahmad",
          Postion = "Founder",
          Description = "Ahmad is the founder of Sabeel and has been a driving force behind the organization since its inception. He is deeply passionate about empowering Arab youth and fostering a sense of pride and appreciation for their cultural heritage.",
        },
        new TeemMember
        {
          Id = 2,
          Name = "Ahmad",
          Postion = "Founder",
          Description = "Ahmad is the founder of Sabeel and has been a driving force behind the organization since its inception. He is deeply passionate about empowering Arab youth and fostering a sense of pride and appreciation for their cultural heritage.",
        },
        new TeemMember
        {
          Id = 3,
          Name = "Ahmad",
          Postion = "Founder",
          Description = "Ahmad is the founder of Sabeel and has been a driving force behind the organization since its inception. He is deeply passionate about empowering Arab youth and fostering a sense of pride and appreciation for their cultural heritage.",
        }
        );
      builder.Entity<Contacts>().HasData(
        new Contacts
        {
          Id = 1,
          PhoneNumber = "123-456-7890",
          Email = "Sabeel@aucegyp.edu",
          Address = "AUC, New Cairo, Egypt",
        });
      builder.Entity<Event>().HasData(
        new Event
        {
          Id = 1,
          Title = "Arab Youth Summit",
          Date = DateTime.Parse("2022-05-01"),
          price = "Free",
          Description = "The Arab Youth Summit is an annual event that brings together young people from across the Arab world to engage in dialogue, exchange ideas, and develop innovative solutions to the challenges facing their communities. The summit features a wide range of workshops, panel discussions, and cultural activities, providing participants with the opportunity to connect with like-minded peers and gain valuable skills and knowledge.",
          Image = "https://via.placeholder.com/150",
        },
        new Event
        {
          Id = 2,
          Title = "Cultural Exchange Program",
          Date = DateTime.Parse("2022-07-15"),
          price = "Free",
          Description = "The Cultural Exchange Program is a unique opportunity for young people to immerse themselves in the rich cultural heritage of the Arab world. Participants will have the chance to explore historical sites, engage with local communities, and learn about the traditions and customs of the region. The program aims to foster a deeper understanding and appreciation of Arab culture and identity, while promoting cross-cultural dialogue and friendship.",
          Image = "https://via.placeholder.com/150",
        },
        new Event
        {
          Id = 3,
          Title = "Youth Leadership Workshop",
          Date = DateTime.Parse("2022-09-30"),
          price = "Free",
          Description = "The Youth Leadership Workshop is designed to equip young people with the skills and knowledge they need to become effective leaders and change-makers in their communities. Through a series of interactive sessions and activities, participants will learn about leadership styles, communication strategies, and project management, while also gaining insights into the social and political issues facing the Arab world. The workshop aims to inspire and empower young people to take on leadership roles and make a positive impact in their societies.",
          Image = "https://via.placeholder.com/150",
        }
      ); 

     builder.Entity<Event>()
        .HasOne(e => e.Image)
        .WithOne(i => i.Event)
        .HasForeignKey<Event>(e => e.ImageId);
     builder.Entity<TeemMember>()
        .HasOne(t => t.Image)
        .WithOne(i => i.TeemMember)
        .HasForeignKey<TeemMember>(t => t.ImageId);

      base.OnModelCreating(builder);
    }


  }
}
