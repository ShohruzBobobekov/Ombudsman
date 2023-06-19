﻿using Ombudsman.BizLogicLayer.Manual;

namespace Ombudsman.BizLogicLayer;

public class StateProgramDto
{
    public int Id { get; set; }
    public string OrderNumber { get; set; }
    public string ShortName { get; set; }
    public string FullName { get; set; }
    public int StateId { get; set; }

    public virtual StateDto State { get; set; }
}
