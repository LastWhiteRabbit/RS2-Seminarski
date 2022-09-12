import 'package:flutter/widgets.dart';
import 'package:ironvault_mobile/model/exercise.dart';
import 'package:ironvault_mobile/model/routine_client.dart';
import 'package:collection/collection.dart';

class RoutineClientProvider with ChangeNotifier {
  RoutineClient routineClient = RoutineClient();
  addToRoutine(Exercise exercise) {
    if (findInRoutine(exercise) != null) {
      findInRoutine(exercise)?.count++;
    } else {
      routineClient.items.add(RoutineItem(exercise, 1));
    }

    notifyListeners();
  }

  removeFromCart(Exercise exercise) {
    routineClient.items
        .removeWhere((item) => item.exercise.exerciseId == exercise.exerciseId);
    notifyListeners();
  }

  RoutineItem? findInRoutine(Exercise exercise) {
    RoutineItem? item = routineClient.items.firstWhereOrNull(
        (item) => item.exercise.exerciseId == exercise.exerciseId);
    return item;
  }
}
