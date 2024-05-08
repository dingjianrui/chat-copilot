using System.Text.Json.Serialization;
using CopilotChat.WebApi.Storage;

namespace CopilotChat.WebApi.Models.Storage;
public class HealthReport : IStorageEntity
{
    [JsonIgnore]
    public string Id { get; set; }

    [JsonPropertyOrder(1)]
    public int total_score { get; set; }

    [JsonPropertyOrder(2)]
    public int body_score { get; set; }

    [JsonPropertyOrder(3)]
    public int custom_score { get; set; }

    [JsonPropertyOrder(4)]
    public int sport_score { get; set; }

    [JsonPropertyOrder(5)]
    public int diet_score { get; set; }

    [JsonPropertyOrder(6)]
    public int shape_score { get; set; }

    [JsonPropertyName("年龄"), JsonPropertyOrder(7)]
    public string? age { get; set; }

    [JsonPropertyName("性别"), JsonPropertyOrder(8)]
    public string? sex { get; set; }

    [JsonPropertyName("身高"), JsonPropertyOrder(9)]
    public double height { get; set; }

    [JsonPropertyName("体重"), JsonPropertyOrder(10)]
    public int weight { get; set; }

    [JsonPropertyName("体脂率"), JsonPropertyOrder(11)]
    public string? body_fat_rate { get; set; }

    [JsonPropertyName("体重管理目标"), JsonPropertyOrder(12)]
    public string? weight_mgmt_goal { get; set; }

    [JsonPropertyName("减肥方法"), JsonPropertyOrder(13)]
    public string? ways_of_losting_weight { get; set; }

    [JsonPropertyName("健康需求"), JsonPropertyOrder(14)]
    public string? health_requirement { get; set; }

    [JsonPropertyName("是否超重"), JsonPropertyOrder(15)]
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

    [JsonPropertyName("饮食习惯"), JsonPropertyOrder(16)]
    public string? dietary_habit { get; set; }

    [JsonPropertyName("生活习惯"), JsonPropertyOrder(17)]
    public string? life_style { get; set; }

    [JsonPropertyName("睡眠习惯"), JsonPropertyOrder(18)]
    public string? sleeping_habit { get; set; }

    [JsonPropertyName("免疫健康困扰"), JsonPropertyOrder(19)]
    public string? Immune_health_concerns { get; set; }

    [JsonPropertyName("皮肤困扰"), JsonPropertyOrder(20)]
    public string? skin_troubles { get; set; }

    [JsonPropertyName("运动次数"), JsonPropertyOrder(21)]
    public string? number_of_excercises { get; set; }

    [JsonPropertyName("身体不适"), JsonPropertyOrder(22)]
    public string? under_the_weather { get; set; }

    [JsonPropertyName("肠胃不适"), JsonPropertyOrder(23)]
    public string? gastrointestinal_upset { get; set; }

    [JsonPropertyName("眼睛不适"), JsonPropertyOrder(24)]
    public string? eye_discomfort { get; set; }

    [JsonPropertyName("骨骼关节"), JsonPropertyOrder(25)]
    public string? bones_and_joints { get; set; }

    [JsonPropertyName("是否食用保健品"), JsonPropertyOrder(26)]
    public string? take_nutritional_supplements { get; set; }
    // assessment
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

    [JsonPropertyName("自我身体检查"), JsonPropertyOrder(27)]
    public string? Physical_Self_examination { get; set; }
    [JsonIgnore]
    public string? Nutritional_Supplements { get; set; }
    [JsonIgnore]
    public string? Fixed_Copy { get; set; }

    [JsonIgnore]
    public string Partition => this.Id;
}

