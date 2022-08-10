import 'dart:convert';

import 'package:json_annotation/json_annotation.dart';

part 'muscle.g.dart';

@JsonSerializable()
class Muscle {
  int? muscleId;
  String? muscleName;

  Muscle() {}
}
