//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ice.Project.Config {


  public class GlobalTemplate : IGeneratorObject {

    // 名字字数限制
    public int NameLimit { get; private set; }

    // 命中修正系数
    public double HitCorrection { get; private set; }

    // 等级区间
    public LevelRange_ LevelRange { get; private set; }

    // 初始任务获得道具
    public int[] InitItems { get; private set; }

    public void Read(ConfigElement element) {
      this.NameLimit = GeneratorUtility.Get(element, "NameLimit", this.NameLimit);
      this.HitCorrection = GeneratorUtility.Get(element, "HitCorrection", this.HitCorrection);
      this.LevelRange = GeneratorUtility.Get(element, "LevelRange", this.LevelRange);
      this.InitItems = GeneratorUtility.Get(element, "InitItems", this.InitItems);
      this.OnInit();
    }

    protected virtual void OnInit() {
    }

    public static GlobalTemplate Load() {
      return Load<GlobalTemplate>();
    }

    public static T Load<T>()
        where T : GlobalTemplate, new() {
      return GeneratorUtility.Load<T>("GlobalConfig");
    }

    public sealed class LevelRange_ : IGeneratorObject {

      public int Min { get; private set; }

      public int Max { get; private set; }

      public void Read(ConfigElement element) {
        this.Min = GeneratorUtility.Get(element, "Min", this.Min);
        this.Max = GeneratorUtility.Get(element, "Max", this.Max);
      }
    }
  }
}
