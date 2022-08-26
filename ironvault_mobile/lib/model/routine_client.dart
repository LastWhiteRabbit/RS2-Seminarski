import 'package:ironvault_mobile/model/exercise.dart';

class RoutineClient {
  List<RoutineItem> items = [];
}

class RoutineItem {
  RoutineItem(this.exercise, this.count);
  late Exercise exercise;
  late int count;
}
