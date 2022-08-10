import 'dart:convert';

import 'package:json_annotation/json_annotation.dart';

part 'muscle.g.dart';

@JsonSerializable()
class Muscle {
  int? muscleId;
  String? muscleName;

  Muscle() {}

  factory Muscle.fromJson(Map<String, dynamic> json) => _$MuscleFromJson(json);

  Map<String, dynamic> toJson() => _$MuscleToJson(this);
}
