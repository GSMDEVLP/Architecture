public class EntityConfigAdapter 
{
    public EntityParametersDefenition ToDefenition(EntityParameters entityParameters)
    {
        Stats stats = new Stats(entityParameters.Stats.strength, 
                                entityParameters.Stats.agility, 
                                entityParameters.Stats.intelligence);
        Resources resources = new Resources(entityParameters.Resources.health, 
                                            entityParameters.Resources.mana, 
                                            entityParameters.Resources.stamina,
                                            entityParameters.Resources.armor);
        return new EntityParametersDefenition(stats, resources);
    }
}
