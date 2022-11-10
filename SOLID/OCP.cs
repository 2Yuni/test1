using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    internal class OCP
    {
        public class Builder : IBuild
        {
            public void BuildHouse()
            {
                // do something
            }
            public void BuildSauna()
            {
                // do something
            }
            public void BuildTerrasa()
            {
                // do something 
            }


        }
        public class BuilderProxy : IBuild
        {
            private Builder _builder;
            public BuilderProxy(Builder builder)
            {
                _builder = builder;
            }
            public void BuildHouse() { _builder.BuildHouse(); }
            public void BuildSauna() { _builder.BuildSauna(); }
            public void BuildTerrasa() { _builder.BuildTerrasa(); }
        }
        public interface IBuildHouse
        {
            public void BuildHouse();
        }
        public interface IBuildSauna
        {
            public void BuildSauna();
        }
        public interface IBuildTerrasa
        {
            public void BuildTerrasa();
        }

        public interface IBuild : IBuildHouse, IBuildSauna, IBuildTerrasa
        {
            
        }

        /*

        abstract class Builder
        {
            protected abstract void Build();

        }

        class BuildHouse : Builder
        {
            protected override void Build()
            {
                // do something
            }

        }

        class BuildSauna : Builder
        {
            protected override void Build()
            {
                // do something
            }

        }*/
    }
}
