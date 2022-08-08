import 'package:ironvault_mobile/model/exercise.dart';
import 'package:ironvault_mobile/providers/base_provider.dart';

class ExerciseProvider extends BaseProvider<Exercise> {
  ExerciseProvider() : super("Exercises");
  @override
  Exercise fromJson(data) {
    return Exercise.fromJson(data);
  }
}
