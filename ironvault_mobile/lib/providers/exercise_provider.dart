import 'dart:convert';

import 'package:ironvault_mobile/model/exercise.dart';
import 'package:ironvault_mobile/providers/base_provider.dart';

class ExerciseProvider extends BaseProvider<Exercise> {
  ExerciseProvider() : super("Exercise");
  @override
  Exercise fromJson(data) {
    return Exercise.fromJson(data);
  }

  Future<Exercise> getRecommendedExercise(int id,
      [dynamic additionalData]) async {
    var url = Uri.parse("https://10.0.2.2:7113/api/Exercise/$id/Recommend");
    //var url = Uri.parse("http://10.0.2.2:5192/api/Exercise/$id/Recommend");

    Map<String, String> headers = createHeaders();

    var response = await http!.get(url, headers: headers);

    if (isValidResponseCode(response)) {
      var data = jsonDecode(response.body);
      return Exercise.fromJson(data[0]);
    } else {
      throw Exception("Unexpected error");
    }
  }
}
