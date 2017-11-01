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


  public class HeroTemplate : IGeneratorObject {

    // 索引
    public int Id { get; private set; }

    // 坐骑
    public int MountId { get; private set; }

    // 性别
    public bool Sex { get; private set; }

    // 身高
    public double Height { get; private set; }

    // 武器
    public int[] Weapons { get; private set; }

    // 主要属性
    public Property_ Property { get; private set; }

    // 背包
    public Bag_[] Bags { get; private set; }

    public void Read(ConfigElement element) {
      this.Id = GeneratorUtility.Get(element, "Id", this.Id);
      this.MountId = GeneratorUtility.Get(element, "MountId", this.MountId);
      this.Sex = GeneratorUtility.Get(element, "Sex", this.Sex);
      this.Height = GeneratorUtility.Get(element, "Height", this.Height);
      this.Weapons = GeneratorUtility.Get(element, "Weapons", this.Weapons);
      this.Property = GeneratorUtility.Get(element, "Property", this.Property);
      this.Bags = GeneratorUtility.Get(element, "Bags", this.Bags);
      this.OnInit();
    }

    protected virtual void OnInit() {
    }

    public static HeroTemplate[] Load() {
      return Load<HeroTemplate>();
    }

    public static T[] Load<T>()
        where T : HeroTemplate, new() {
      return GeneratorUtility.Load<T>("HerosConfig", "Hero");
    }

    public sealed class Property_ : IGeneratorObject {

      public int Hp { get; private set; }

      public int Magic { get; private set; }

      public void Read(ConfigElement element) {
        this.Hp = GeneratorUtility.Get(element, "Hp", this.Hp);
        this.Magic = GeneratorUtility.Get(element, "Magic", this.Magic);
      }
    }

    public sealed class Bag_ : IGeneratorObject {

      public int Id { get; private set; }

      public int Count { get; private set; }

      public void Read(ConfigElement element) {
        this.Id = GeneratorUtility.Get(element, "Id", this.Id);
        this.Count = GeneratorUtility.Get(element, "Count", this.Count);
      }
    }
  }
}
