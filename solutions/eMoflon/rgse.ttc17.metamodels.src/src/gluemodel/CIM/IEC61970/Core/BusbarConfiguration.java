/**
 */
package gluemodel.CIM.IEC61970.Core;

import java.util.Arrays;
import java.util.Collections;
import java.util.List;

import org.eclipse.emf.common.util.Enumerator;

/**
 * <!-- begin-user-doc -->
 * A representation of the literals of the enumeration '<em><b>Busbar Configuration</b></em>',
 * and utility methods for working with them.
 * <!-- end-user-doc -->
 * @see gluemodel.CIM.IEC61970.Core.CorePackage#getBusbarConfiguration()
 * @model
 * @generated
 */
public enum BusbarConfiguration implements Enumerator {
	/**
	 * The '<em><b>Main With Transfer</b></em>' literal object.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @see #MAIN_WITH_TRANSFER_VALUE
	 * @generated
	 * @ordered
	 */
	MAIN_WITH_TRANSFER(0, "mainWithTransfer", "mainWithTransfer"),

	/**
	 * The '<em><b>Ring Bus</b></em>' literal object.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @see #RING_BUS_VALUE
	 * @generated
	 * @ordered
	 */
	RING_BUS(1, "ringBus", "ringBus"),

	/**
	 * The '<em><b>Double Bus</b></em>' literal object.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @see #DOUBLE_BUS_VALUE
	 * @generated
	 * @ordered
	 */
	DOUBLE_BUS(2, "doubleBus", "doubleBus"),

	/**
	 * The '<em><b>Single Bus</b></em>' literal object.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @see #SINGLE_BUS_VALUE
	 * @generated
	 * @ordered
	 */
	SINGLE_BUS(3, "singleBus", "singleBus");

	/**
	 * The '<em><b>Main With Transfer</b></em>' literal value.
	 * <!-- begin-user-doc -->
	 * <p>
	 * If the meaning of '<em><b>Main With Transfer</b></em>' literal object isn't clear,
	 * there really should be more of a description here...
	 * </p>
	 * <!-- end-user-doc -->
	 * @see #MAIN_WITH_TRANSFER
	 * @model name="mainWithTransfer"
	 * @generated
	 * @ordered
	 */
	public static final int MAIN_WITH_TRANSFER_VALUE = 0;

	/**
	 * The '<em><b>Ring Bus</b></em>' literal value.
	 * <!-- begin-user-doc -->
	 * <p>
	 * If the meaning of '<em><b>Ring Bus</b></em>' literal object isn't clear,
	 * there really should be more of a description here...
	 * </p>
	 * <!-- end-user-doc -->
	 * @see #RING_BUS
	 * @model name="ringBus"
	 * @generated
	 * @ordered
	 */
	public static final int RING_BUS_VALUE = 1;

	/**
	 * The '<em><b>Double Bus</b></em>' literal value.
	 * <!-- begin-user-doc -->
	 * <p>
	 * If the meaning of '<em><b>Double Bus</b></em>' literal object isn't clear,
	 * there really should be more of a description here...
	 * </p>
	 * <!-- end-user-doc -->
	 * @see #DOUBLE_BUS
	 * @model name="doubleBus"
	 * @generated
	 * @ordered
	 */
	public static final int DOUBLE_BUS_VALUE = 2;

	/**
	 * The '<em><b>Single Bus</b></em>' literal value.
	 * <!-- begin-user-doc -->
	 * <p>
	 * If the meaning of '<em><b>Single Bus</b></em>' literal object isn't clear,
	 * there really should be more of a description here...
	 * </p>
	 * <!-- end-user-doc -->
	 * @see #SINGLE_BUS
	 * @model name="singleBus"
	 * @generated
	 * @ordered
	 */
	public static final int SINGLE_BUS_VALUE = 3;

	/**
	 * An array of all the '<em><b>Busbar Configuration</b></em>' enumerators.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	private static final BusbarConfiguration[] VALUES_ARRAY =
		new BusbarConfiguration[] {
			MAIN_WITH_TRANSFER,
			RING_BUS,
			DOUBLE_BUS,
			SINGLE_BUS,
		};

	/**
	 * A public read-only list of all the '<em><b>Busbar Configuration</b></em>' enumerators.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	public static final List<BusbarConfiguration> VALUES = Collections.unmodifiableList(Arrays.asList(VALUES_ARRAY));

	/**
	 * Returns the '<em><b>Busbar Configuration</b></em>' literal with the specified literal value.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @param literal the literal.
	 * @return the matching enumerator or <code>null</code>.
	 * @generated
	 */
	public static BusbarConfiguration get(String literal) {
		for (int i = 0; i < VALUES_ARRAY.length; ++i) {
			BusbarConfiguration result = VALUES_ARRAY[i];
			if (result.toString().equals(literal)) {
				return result;
			}
		}
		return null;
	}

	/**
	 * Returns the '<em><b>Busbar Configuration</b></em>' literal with the specified name.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @param name the name.
	 * @return the matching enumerator or <code>null</code>.
	 * @generated
	 */
	public static BusbarConfiguration getByName(String name) {
		for (int i = 0; i < VALUES_ARRAY.length; ++i) {
			BusbarConfiguration result = VALUES_ARRAY[i];
			if (result.getName().equals(name)) {
				return result;
			}
		}
		return null;
	}

	/**
	 * Returns the '<em><b>Busbar Configuration</b></em>' literal with the specified integer value.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @param value the integer value.
	 * @return the matching enumerator or <code>null</code>.
	 * @generated
	 */
	public static BusbarConfiguration get(int value) {
		switch (value) {
			case MAIN_WITH_TRANSFER_VALUE: return MAIN_WITH_TRANSFER;
			case RING_BUS_VALUE: return RING_BUS;
			case DOUBLE_BUS_VALUE: return DOUBLE_BUS;
			case SINGLE_BUS_VALUE: return SINGLE_BUS;
		}
		return null;
	}

	/**
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	private final int value;

	/**
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	private final String name;

	/**
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	private final String literal;

	/**
	 * Only this class can construct instances.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	private BusbarConfiguration(int value, String name, String literal) {
		this.value = value;
		this.name = name;
		this.literal = literal;
	}

	/**
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	public int getValue() {
	  return value;
	}

	/**
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	public String getName() {
	  return name;
	}

	/**
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	public String getLiteral() {
	  return literal;
	}

	/**
	 * Returns the literal value of the enumerator, which is its string representation.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	@Override
	public String toString() {
		return literal;
	}
	
} //BusbarConfiguration
