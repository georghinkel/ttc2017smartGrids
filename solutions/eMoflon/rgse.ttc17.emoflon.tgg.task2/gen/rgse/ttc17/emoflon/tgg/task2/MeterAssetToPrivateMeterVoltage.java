/**
 */
package rgse.ttc17.emoflon.tgg.task2;

import gluemodel.CIM.IEC61968.Metering.MeterAsset;

import org.eclipse.emf.ecore.EObject;

import org.moflon.tgg.runtime.AbstractCorrespondence;

import outagePreventionJointarget.PrivateMeterVoltage;
// <-- [user defined imports]
// [user defined imports] -->

/**
 * <!-- begin-user-doc -->
 * A representation of the model object '<em><b>Meter Asset To Private Meter Voltage</b></em>'.
 * <!-- end-user-doc -->
 *
 * <p>
 * The following features are supported:
 * <ul>
 *   <li>{@link rgse.ttc17.emoflon.tgg.task2.MeterAssetToPrivateMeterVoltage#getSource <em>Source</em>}</li>
 *   <li>{@link rgse.ttc17.emoflon.tgg.task2.MeterAssetToPrivateMeterVoltage#getTarget <em>Target</em>}</li>
 * </ul>
 * </p>
 *
 * @see rgse.ttc17.emoflon.tgg.task2.Task2Package#getMeterAssetToPrivateMeterVoltage()
 * @model
 * @generated
 */
public interface MeterAssetToPrivateMeterVoltage extends EObject, AbstractCorrespondence {
	/**
	 * Returns the value of the '<em><b>Source</b></em>' reference.
	 * <!-- begin-user-doc -->
	 * <p>
	 * If the meaning of the '<em>Source</em>' reference isn't clear,
	 * there really should be more of a description here...
	 * </p>
	 * <!-- end-user-doc -->
	 * @return the value of the '<em>Source</em>' reference.
	 * @see #setSource(MeterAsset)
	 * @see rgse.ttc17.emoflon.tgg.task2.Task2Package#getMeterAssetToPrivateMeterVoltage_Source()
	 * @model required="true"
	 * @generated
	 */
	MeterAsset getSource();

	/**
	 * Sets the value of the '{@link rgse.ttc17.emoflon.tgg.task2.MeterAssetToPrivateMeterVoltage#getSource <em>Source</em>}' reference.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @param value the new value of the '<em>Source</em>' reference.
	 * @see #getSource()
	 * @generated
	 */
	void setSource(MeterAsset value);

	/**
	 * Returns the value of the '<em><b>Target</b></em>' reference.
	 * <!-- begin-user-doc -->
	 * <p>
	 * If the meaning of the '<em>Target</em>' reference isn't clear,
	 * there really should be more of a description here...
	 * </p>
	 * <!-- end-user-doc -->
	 * @return the value of the '<em>Target</em>' reference.
	 * @see #setTarget(PrivateMeterVoltage)
	 * @see rgse.ttc17.emoflon.tgg.task2.Task2Package#getMeterAssetToPrivateMeterVoltage_Target()
	 * @model required="true"
	 * @generated
	 */
	PrivateMeterVoltage getTarget();

	/**
	 * Sets the value of the '{@link rgse.ttc17.emoflon.tgg.task2.MeterAssetToPrivateMeterVoltage#getTarget <em>Target</em>}' reference.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @param value the new value of the '<em>Target</em>' reference.
	 * @see #getTarget()
	 * @generated
	 */
	void setTarget(PrivateMeterVoltage value);
	// <-- [user code injected with eMoflon]

	// [user code injected with eMoflon] -->
} // MeterAssetToPrivateMeterVoltage
