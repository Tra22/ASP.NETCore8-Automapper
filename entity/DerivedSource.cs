namespace AutomapperWebAPIProject.entity {
    public class DerivedSource : UserEntity
    {
        public string DerivedProperty { get; set; }
        public DerivedSource(string id, string firstName, string lastName, int age, string email, string derivedProperty) : base(id, firstName, lastName, age, email)
        {
            this.DerivedProperty = derivedProperty;
        }

    }
}