using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseStorage.entities
{
    public class unit
    {
        public unit(double kh, double kha, double khv, double khb, double omegaHT, double omegaHV, double g0, double sigmaH, double sigmaHP,
            double zh, double zm, double ft, double b, double ea, double re, double def_sigmaH_sigmaHP)
        {
            Kh = kh;
            Kha = kha;
            Khv = khv;
            Khb = khb;
            OmegaHT = omegaHT;
            OmegaHV = omegaHV;
            this.g0 = g0;
            this.sigmaH = sigmaH;
            this.sigmaHP = sigmaHP;
            Zh = zh;
            Zm = zm;
            Ft = ft;
            this.b = b;
            Ea = ea;
            Re = re;
            this.def_sigmaH_sigmaHP = def_sigmaH_sigmaHP;
        }

        
        public Guid Id {  get; set; }

        public double Kh {  get; set; }
        public double Kha {get ; set; }
        public double Khv { get; set; }
        public double Khb {  get; set; }
        public double OmegaHT {  get; set; }
        public double OmegaHV {get; set; }
        public double g0 { get; set; }
        public double sigmaH {  get; set; }
        public double sigmaHP {  get; set; }
        public double Zh {  get; set; }
        public double Zm { get; set; }
        public double Ft { get; set; }
        public double b {  get; set; }
        public double Ea { get; set; }
        public double Re {  get; set; }
        public double def_sigmaH_sigmaHP {  get; set; }

    }
}
