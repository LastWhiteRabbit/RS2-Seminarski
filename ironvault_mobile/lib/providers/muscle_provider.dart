import 'package:ironvault_mobile/model/muscle.dart';
import 'package:ironvault_mobile/providers/base_provider.dart';

class MuscleProvider extends BaseProvider<Muscle> {
  MuscleProvider() : super("Muscle");
  @override
  Muscle fromJson(data) {
    return Muscle.fromJson(data);
  }
}
