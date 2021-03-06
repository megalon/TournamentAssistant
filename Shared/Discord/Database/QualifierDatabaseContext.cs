﻿using Microsoft.EntityFrameworkCore;
using TournamentAssistantShared.Database;

namespace TournamentAssistantShared.Discord.Database
{
    public class QualifierDatabaseContext : DatabaseContext
    {
        public QualifierDatabaseContext(string location) : base(location) { }

        public DbSet<Player> Players { get; set; }
        public DbSet<Song> Songs { get; set; }
    }
}
