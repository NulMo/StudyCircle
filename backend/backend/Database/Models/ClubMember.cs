﻿namespace Database;

public class ClubMember : ITrackable
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public int ClubId { get; set; }

    public bool IsOwner { get; set; }

    public bool IsModerator { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime DeletedAt { get; set; }

    public User User { get; set; } = null!;

    public Club Club { get; set; } = null!;
}