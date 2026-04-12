using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inv.Support;

namespace Pathos
{
  public sealed class CodexQualifications : CodexPage<ManifestQualifications, QualificationEditor, Qualification>
  {
    private CodexQualifications() { }
#if MASTER_CODEX
    internal CodexQualifications(Codex Codex)
      : base(Codex.Manifest.Qualifications)
    {
      Qualification AddQualification(string Code, string Name, int Rating)
      {
        return Register.Add(Q =>
        {
          Q.Code = Code;
          Q.Name = Name;
          Q.Rating = Rating;
        });
      }

     // unskilled = AddQualification("u", "unskilled", -100);
      proficient = AddQualification("p", "proficient", 0);   // +1000
      specialist = AddQualification("s", "specialist", 100); // +200
      expert = AddQualification("e", "expert", 250);         // +300
      master = AddQualification("m", "master", 500);        // +500
      champion = AddQualification("c", "champion", 1000);    // +1000
    }
#endif
   // public readonly Qualification unskilled;
    public readonly Qualification proficient;
    public readonly Qualification specialist;
    public readonly Qualification expert;
    public readonly Qualification master;
    public readonly Qualification champion;
  }
}
