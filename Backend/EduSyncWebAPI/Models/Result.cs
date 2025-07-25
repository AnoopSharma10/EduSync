﻿using System;
using System.Collections.Generic;

namespace EduSyncWebAPI.Models;

public partial class Result
{
    public Guid ResultId { get; set; }

    public Guid? AssessmentId { get; set; }

    public Guid? UserId { get; set; }

    public int? Score { get; set; }

    public DateOnly? AttemptDate { get; set; }

    public virtual Assessment? Assessment { get; set; }

    public virtual UserModel? User { get; set; }
}
