﻿using System;
using System.Collections.Generic;

namespace TrangDoctor.Data;

public partial class MedicalRecord
{
    public int RecordId { get; set; }

    public int PatientId { get; set; }

    public int DoctorId { get; set; }

    public DateOnly DateMedical { get; set; }

    public string Diagnosis { get; set; } = null!;

    public string Treatment { get; set; } = null!;

    public string? Notes { get; set; }

    public virtual Doctor Doctor { get; set; } = null!;

    public virtual Patient Patient { get; set; } = null!;
}
