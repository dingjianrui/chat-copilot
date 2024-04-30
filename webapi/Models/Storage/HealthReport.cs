using System.Text.Json.Serialization;
using CopilotChat.WebApi.Storage;

namespace CopilotChat.WebApi.Models.Storage;
public class HealthReport : IStorageEntity
{
  public string Id { get; set; }
  public int total_score { get; set; }
  public int body_score { get; set; }
  public int custom_score { get; set; }
  public int sport_score { get; set; }
  public int diet_score { get; set; }
  public int shape_score { get; set; }
  public string? age { get; set; }
  public string? sex { get; set; }
  public double height { get; set; }
  public int weight { get; set; }
  public string? body_fat_rate { get; set; }
  public string? weight_mgmt_goal { get; set; }
  public string? ways_of_losting_weight { get; set; }
  public string? health_requirement { get; set; }
  public string? overweight { get; set; }
  [JsonIgnore]
  public string? staple_food_consumed { get; set; }
  [JsonIgnore]
  public string? coarse_grains_consumed { get; set; }
  [JsonIgnore]
  public string? number_of_vegetables { get; set; }
  [JsonIgnore]
  public string? number_of_fruits { get; set; }
  [JsonIgnore]
  public string? number_of_meat { get; set; }
  [JsonIgnore]
  public string? number_of_eggs { get; set; }
  [JsonIgnore]
  public string? number_of_beans { get; set; }
  [JsonIgnore]
  public string? number_of_yogurt { get; set; }
  [JsonIgnore]
  public string? number_of_nuts { get; set; }
  [JsonIgnore]
  public string? number_of_water { get; set; }
  [JsonIgnore]
  public string? number_of_cooking_oil { get; set; }
  [JsonIgnore]
  public string? salt_more_than_5_grams { get; set; }
  [JsonIgnore]
  public string? high_fat_food { get; set; }
  [JsonIgnore]
  public string? high_suger_food { get; set; }
  [JsonIgnore]
  public string? high_salt_food { get; set; }
  [JsonIgnore]
  public string? dietary_habit { get; set; }
  public string? life_style { get; set; }
  public string? sleeping_habit { get; set; }
  public string? Immune_health_concerns { get; set; }

  public string? skin_troubles { get; set; }
  public string? number_of_excercises { get; set; }
  public string? under_the_weather { get; set; }
  public string? gastrointestinal_upset { get; set; }
  public string? eye_discomfort { get; set; }
  public string? bones_and_joints { get; set; }
  public string? take_nutritional_supplements { get; set; }
  [JsonIgnore]
  public string? Weight_Gain_Trend { get; set; }
  [JsonIgnore]
  public string? Health_Needs { get; set; }
  [JsonIgnore]
  public string? Weight_Management_Goals { get; set; }
  [JsonIgnore]
  public string? Dietary_Structure { get; set; }
  [JsonIgnore]
  public string? Dietary_Structure_Assessment { get; set; }
  [JsonIgnore]
  public string? Lifestyle_abits { get; set; }
  [JsonIgnore]
  public string? Physical_Self_examination { get; set; }
  public string? Nutritional_Supplements { get; set; }
  public string? Fixed_Copy { get; set; }

  [JsonIgnore]
  public string Partition => this.sex;
}

