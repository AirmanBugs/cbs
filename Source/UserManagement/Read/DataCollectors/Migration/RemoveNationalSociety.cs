using System;
using Infrastructure.Read.Migration;

namespace Read.DataCollectors.Migration
{
    public class RemoveNationalSociety : IMigrationStrategyFor<DataCollector>
    {
        public DataCollector ApplyMigrationStrategy(DataCollector readModel)
        {
            throw new NotImplementedException();
            // readModel.ExtraElements.Remove("NationalSociety");
            // return readModel;
        }

        public bool CanMigrate(DataCollector readModel)
        {
            throw new NotImplementedException();
            // if (readModel.ExtraElements == null) return false;
            // return readModel.ExtraElements.ContainsKey("NationalSociety");
        }
    }
}