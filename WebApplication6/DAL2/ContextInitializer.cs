using System.Collections.Generic;
using System.Data.Entity;

namespace DAL
{
    public class ContextInitializer : DropCreateDatabaseAlways<Context>
    {
        private List<StaticNumbers> _staticNumbers;
        private List<RandomNumbers> _randomNumbers;

        public ContextInitializer()
        {
            _staticNumbers = new List<StaticNumbers>();
            _randomNumbers = new List<RandomNumbers>();
        }


        public override void InitializeDatabase(Context context)
        {
            _staticNumbers.ForEach(x => context.StaticNumbers.Add(x));
            _randomNumbers.ForEach(x => context.RandomNumbers.Add(x));
            base.InitializeDatabase(context);
        }
    }
}
