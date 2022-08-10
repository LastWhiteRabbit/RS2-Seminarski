import 'package:ironvault_mobile/model/exercisetype.dart';
import 'package:ironvault_mobile/providers/base_provider.dart';

class ExerciseTypeProvider extends BaseProvider<ExerciseType> {
  ExerciseTypeProvider() : super("ExerciseType");
  @override
  ExerciseType fromJson(data) {
    return ExerciseType.fromJson(data);
  }
}
