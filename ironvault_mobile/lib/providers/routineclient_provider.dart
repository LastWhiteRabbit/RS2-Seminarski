import 'package:flutter/cupertino.dart';
import 'package:ironvault_mobile/model/exercise.dart';
import 'package:ironvault_mobile/model/routine_client.dart';

class RoutineClientProvider with ChangeNotifier {
  RoutineClient routineClient = RoutineClient();
  addToRoutine(Exercise exercise) {
    if (findInRoutine(exercise) != null) {
      findInRoutine(exercise).count++;
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

  findInRoutine(Exercise exercise) {
    return routineClient.items
        .firstWhere((item) => item.exercise.exerciseId == exercise.exerciseId);
  }
}
