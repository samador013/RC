﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCIDRepository.Domain
{
    public class PhytoSpecies
    {
        public short SpeciesID { get; set; }
        public byte DivisionID { get; set; }
        public string DivisionName { get; set; }
        public string SpeciesName { get; set; }
        public bool SpeciesActive { get; set; }
    }
}
