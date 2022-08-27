import 'package:ironvault_mobile/model/routine.dart';
import 'package:ironvault_mobile/providers/base_provider.dart';

class RoutineProvider extends BaseProvider<Routine> {
  RoutineProvider() : super("Routine");
  @override
  Routine fromJson(data) {
    // TODO: implement fromJson
    return Routine();
  }
}
